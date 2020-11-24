using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Clio.Org.Data;
using Clio.Org.Model;

namespace Clio.Org.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrganizationsController : ControllerBase
    {
        private readonly OrganizationContext _context;

        public OrganizationsController(OrganizationContext context)
        {
            _context = context;
        }


        [HttpGet]
        [Route("GetEntireOrg")]
        public IEnumerable<Organization> GetOrganization()
        {
            return _context.Organization.ToList();
        }

        [HttpGet("{id}")]
        [Route("GetChildNodesFrom/{id}")]
        public IEnumerable<Organization> GetChildNodes(int id)
        {
            var oneLayerSubNode = _context.Organization.Where(p => p.Parent == id);
            return oneLayerSubNode;
        }
        
        [HttpPost]
        public async Task<ActionResult<Organization>> PostOrganization(Organization organization)
        {
            _context.Organization.Add(organization);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrganization", new { id = organization.Id }, organization);
        }

        [HttpPost]
        [Route("ChangeParent")]
        public Organization PostOrganization(HelperModel model)
        {
            var node = _context.Organization.Where(p => p.Id == model.Node).FirstOrDefault<Organization>();
            node.Parent = model.ToParent;
            _context.Update(node);
            _context.SaveChanges();
            return node;
        }



        private bool OrganizationExists(int id)
        {
            return _context.Organization.Any(e => e.Id == id);
        }
    }
}
