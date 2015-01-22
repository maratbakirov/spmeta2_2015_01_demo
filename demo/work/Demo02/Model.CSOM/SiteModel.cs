using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPMeta2.BuiltInDefinitions;
using SPMeta2.Enumerations;
using SPMeta2.Models;
using SPMeta2.Standard.Syntax;
using SPMeta2.Syntax.Default;

namespace Model.CSOM
{
    public class SiteModel
    {
        public static ModelNode BuildTaxonomyModel()
        {

            var siteModel = SPMeta2Model.NewSiteModel(

                site =>
                {
                    site.AddTaxonomyTermStore(Taxonomy.TermStore,

                        termStore =>
                        {
                            termStore.AddTaxonomyTermGroup(Taxonomy.RootGroup,
                                group =>
                                {
                                    group.AddTaxonomyTermSet(Taxonomy.Location,
                                        termSet =>
                                        {
                                            termSet.AddTaxonomyTerm(Taxonomy.RootTerm,
                                                term =>
                                                {
                                                    //term.AddTaxonomyTerm(Taxonomy.SubTerm1);
                                                    //term.AddTaxonomyTerm(Taxonomy.SubTerm2);
                                                }
                                                );
                                            termSet.AddTaxonomyTerm(Taxonomy.RootTerm2,
                                                term =>
                                                {
                                                    //term.AddTaxonomyTerm(Taxonomy.SubTerm1);
                                                    //term.AddTaxonomyTerm(Taxonomy.SubTerm2);
                                                }
                                                );
                                        });
                                });
                        });
                }
                );
            return siteModel;
        }
        public static ModelNode BuildFieldsModel()
        {

            var siteModel = SPMeta2Model.NewSiteModel(

                site =>
                {
                    site.AddField(Fields.myfield);
                }
                );
            return siteModel;
        }

      
    }
}
