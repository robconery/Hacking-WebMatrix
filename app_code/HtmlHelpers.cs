using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

/// <summary>
/// Summary description for HtmlHelpers
/// </summary>
namespace System.Web.WebPages.Html {


    public static class HtmlHelpers {

        const string pubDir = "~/public";
        const string cssDir = "stylesheets";
        const string imageDir = "images";
        const string scriptDir = "javascripts";

        public static HtmlString LinkTo(this HtmlHelper helper, string text, string url) {
            return LinkTo(helper, text, url, "");
        }
        public static HtmlString LinkTo(this HtmlHelper helper, string text, string url, string attributes) {
            url = Url.SiteUrl(url);
            return new HtmlString(string.Format("<a href='{2}' {1}>{0}</a>", helper.Encode(text), helper.AttributeEncode(attributes), helper.AttributeEncode(url)));
        }

        public static HtmlString Script(this HtmlHelper helper, string fileName) {
            if (!fileName.EndsWith(".js"))
                fileName += ".js";
            var jsPath = string.Format("<script src='{0}/{1}/{2}' ></script>\n", Url.SiteUrl(pubDir), scriptDir, helper.AttributeEncode(fileName));
            return new HtmlString(jsPath);
        }
        public static HtmlString CSS(this HtmlHelper helper, string fileName) {
            return CSS(helper, fileName, "screen");
        }
        public static HtmlString CSS(this HtmlHelper helper, string fileName, string media) {
            if (!fileName.EndsWith(".css"))
                fileName += ".css";
            var cssPath = string.Format("<link rel='stylesheet' type='text/css' href='{0}/{1}/{2}'  media='" + media + "'/>\n", Url.SiteUrl(pubDir), cssDir, helper.AttributeEncode(fileName));
            return new HtmlString(cssPath);
        }

        public static HtmlString Image(this HtmlHelper helper, string fileName) {
            return Image(helper, fileName, "");
        }
        public static HtmlString Image(this HtmlHelper helper, string fileName, string attributes) {
            fileName = string.Format("{0}/{1}/{2}", Url.SiteUrl(pubDir), imageDir, fileName);
            return new HtmlString(string.Format("<img src='{0}' '{1}' />", helper.AttributeEncode(fileName), helper.AttributeEncode(attributes)));
        }
        public static HtmlString JQuery(this HtmlHelper helper) {
            return helper.Script("jquery-1.3.2.min.js");
        }
        public static HtmlString JQueryUI(this HtmlHelper helper) {
            return helper.Script("jquery-ui-1.7.2.custom.min.js");
        }

    }

}