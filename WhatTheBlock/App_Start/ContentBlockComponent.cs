using Perplex.ContentBlocks.Definitions;
using Perplex.ContentBlocks.Presets;
using System;
using Umbraco.Core.Composing;
using Umbraco.Core.Models;
using Umbraco.Core.PropertyEditors;
using Umbraco.Core.Services;
using Umbraco.Web.PropertyEditors;
using static Umbraco.Core.Constants;

namespace ExampleSite
{
    public class ContentBlockComponent : IComponent
    {
        private readonly IContentBlockDefinitionRepository _definitions;
        private readonly PropertyEditorCollection _propertyEditors;
        private readonly IDataTypeService _dataTypeService;
        private readonly IContentTypeService _contentTypeService;

        public ContentBlockComponent(
            IContentBlockDefinitionRepository definitions,
            PropertyEditorCollection propertyEditors,
            IDataTypeService dataTypeService,
            IContentTypeService contentTypeService)
        {
            _definitions = definitions;
            _propertyEditors = propertyEditors;
            _dataTypeService = dataTypeService;
            _contentTypeService = contentTypeService;
        }

        public void Initialize()
        {

            var heroBlock = new ContentBlockDefinition
            {
                Id = new Guid("7ba212b9-d862-4491-bab1-b939294bcce3"),
                Name = "Hero",
                Description = "",
                PreviewImage = "/ContentBlockPreviews/hero.png",
                DataTypeKey = new Guid("06ba7f15-b311-4393-854f-9f34f0d37ddc"),
                CategoryIds = new Guid[] { Perplex.ContentBlocks.Constants.Categories.Headers },
                Layouts = new IContentBlockLayout[]
                    {
                        new ContentBlockLayout
                        {
                            Id = new Guid("c573e88a-87fa-49ff-8a39-9f2f8dc06645"),
                            Name = "Default",
                            Description = "",
                            PreviewImage = "/ContentBlockPreviews/hero.png",
                            ViewPath = "/Views/Partials/ContentBlocks/Hero.cshtml"
                        }
                    }
            };
            _definitions.Add(heroBlock);


            var serviceListBlock = new ContentBlockDefinition
            {
                Id = new Guid("a5b0bcdd-1a2b-4737-827c-e442e8b6720a"),
                Name = "Services",
                Description = "",
                PreviewImage = "/ContentBlockPreviews/serviceList.png",
                DataTypeKey = new Guid("fa6dd7b6-5730-412e-8b4f-c517ad5c54f0"),
                CategoryIds = new Guid[] { Perplex.ContentBlocks.Constants.Categories.Content },
                Layouts = new IContentBlockLayout[]
                    {
                        new ContentBlockLayout
                        {
                            Id = new Guid("3a9c341f-de6c-4fdb-8331-3e9a578995e5"),
                            Name = "Default",
                            Description = "",
                            PreviewImage = "/ContentBlockPreviews/serviceList.png",
                            ViewPath = "/Views/Partials/ContentBlocks/ServiceList.cshtml"
                        }
                    }
            };
            _definitions.Add(serviceListBlock);


            var quoteBlock = new ContentBlockDefinition
            {
                Id = new Guid("0038cb05-4e16-412d-b475-a8971a03281b"),
                Name = "Quote",
                Description = "",
                PreviewImage = "/ContentBlockPreviews/quote.png",
                DataTypeKey = new Guid("5ee3fc1d-21ee-4ebc-886e-1671c12bb64e"),
                CategoryIds = new Guid[] { Perplex.ContentBlocks.Constants.Categories.Content },
                Layouts = new IContentBlockLayout[]
                    {
                        new ContentBlockLayout
                        {
                            Id = new Guid("59c68bd6-f87c-4ca2-aef4-76e5a0d6124e"),
                            Name = "Default",
                            Description = "",
                            PreviewImage = "/ContentBlockPreviews/quote.png",
                            ViewPath = "/Views/Partials/ContentBlocks/Quote.cshtml"
                        },
                        new ContentBlockLayout
                        {
                            Id = new Guid("9439cd51-7399-41eb-a0fe-333f9605f795"),
                            Name = "Quote first",
                            Description = "",
                            PreviewImage = "/ContentBlockPreviews/quote2.png",
                            ViewPath = "/Views/Partials/ContentBlocks/Quote2.cshtml"
                        }
                    }
            };
            _definitions.Add(quoteBlock);


            var galleryBlock = new ContentBlockDefinition
            {
                Id = new Guid("dedcae1c-c8f5-4577-a076-3cad64c29ed1"),
                Name = "Gallery",
                Description = "",
                PreviewImage = "/ContentBlockPreviews/gallery.png",
                DataTypeKey = new Guid("a6505793-d442-4262-ae8d-319e12bdfd84"),
                CategoryIds = new Guid[] { Perplex.ContentBlocks.Constants.Categories.Content },
                Layouts = new IContentBlockLayout[]
                    {
                        new ContentBlockLayout
                        {
                            Id = new Guid("1ad657ac-25b0-4d7a-9f02-81d30a284760"),
                            Name = "Default",
                            Description = "",
                            PreviewImage = "/ContentBlockPreviews/gallery.png",
                            ViewPath = "/Views/Partials/ContentBlocks/Gallery.cshtml"
                        }
                    }
            };
            _definitions.Add(galleryBlock);
        }

        public void Terminate()
        {
        }
    }

    [RuntimeLevel(MinLevel = Umbraco.Core.RuntimeLevel.Run)]
    public class ContentBlockComposer : ComponentComposer<ContentBlockComponent> { }
}