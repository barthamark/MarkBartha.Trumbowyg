using Orchard.UI.Resources;

namespace MarkBartha.Trumbowyg {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();

            manifest.DefineScript("Trumbowyg").SetUrl("../Content/Trumbowyg/trumbowyg.min.js").SetDependencies("jQuery");
            manifest.DefineScript("Trumbowyg.Base64").SetUrl("../Content/Trumbowyg/plugins/base64/trumbowyg.base64.min.js").SetDependencies("Trumbowyg");
            manifest.DefineScript("Trumbowyg.CleanPaste").SetUrl("../Content/Trumbowyg/plugins/cleanpaste/trumbowyg.cleanpaste.min.js").SetDependencies("Trumbowyg");
            manifest.DefineScript("Trumbowyg.Colors").SetUrl("../Content/Trumbowyg/plugins/colors/trumbowyg.colors.min.js").SetDependencies("Trumbowyg");
            manifest.DefineScript("Trumbowyg.Emoji").SetUrl("../Content/Trumbowyg/plugins/emoji/trumbowyg.emoji.min.js").SetDependencies("Trumbowyg");
            manifest.DefineScript("Trumbowyg.NoEmbed").SetUrl("../Content/Trumbowyg/plugins/noembed/trumbowyg.noembed.min.js").SetDependencies("Trumbowyg");
            manifest.DefineScript("Trumbowyg.Preformatted").SetUrl("../Content/Trumbowyg/plugins/preformatted/trumbowyg.preformatted.min.js").SetDependencies("Trumbowyg");
            manifest.DefineScript("Trumbowyg.Table").SetUrl("../Content/Trumbowyg/plugins/table/trumbowyg.table.min.js").SetDependencies("Trumbowyg");
            manifest.DefineScript("Trumbowyg.Template").SetUrl("../Content/Trumbowyg/plugins/template/trumbowyg.template.min.js").SetDependencies("Trumbowyg");
            manifest.DefineScript("Trumbowyg.MediaLibrary").SetUrl("trumbowyg.medialibrary.js").SetDependencies("Trumbowyg", "jQueryColorBox");

            manifest.DefineStyle("Trumbowyg").SetUrl("trumbowyg-orchard.min.css");
            manifest.DefineStyle("Trumbowyg.Colors").SetUrl("../Content/Trumbowyg/plugins/colors/ui/trumbowyg.colors.min.css").SetDependencies("Trumbowyg");
            //manifest.DefineScript("Trumbowyg").SetCdn("https://cloud.tinymce.com/stable/tinymce.min.js");
            //manifest.DefineStyle("Trumbowyg").SetCdn("https://cdn.quilljs.com/1.2.4/quill.snow.css");
        }
    }
}
