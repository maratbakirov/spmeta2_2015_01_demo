using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPMeta2.Standard.Definitions.Fields;
using SPMeta2.Standard.Definitions.Taxonomy;

namespace Model
{
    public class Fields
    {

        public static TaxonomyFieldDefinition myfield = new TaxonomyFieldDefinition()
        {
            Id = new Guid("{157D2E98-DB45-44F2-A0B3-79A70AA71CF7}"),
            InternalName = "taxfield",
            Title = "taxf1",
            Group = "UG",
            TermSetName = Taxonomy.Location.Name,
            TermSetId = Taxonomy.Location.Id,
            TermLCID = 1033,
            UseDefaultSiteCollectionTermStore = true

        };

    }
}
