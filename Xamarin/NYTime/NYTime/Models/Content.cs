using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NYTime.Models
{
    public class RelatedUrl
    {
        public string suggested_link_text { get; set; }
        public string url { get; set; }
    }

    public class Multimedia
    {
        public string url { get; set; }
        public string format { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public string type { get; set; }
        public string subtype { get; set; }
        public string caption { get; set; }
        public string copyright { get; set; }
    }

    public class NewInfo
    {
        public string slug_name { get; set; }
        public string section { get; set; }
        public string subsection { get; set; }
        public string title { get; set; }
        [JsonProperty(PropertyName = "abstract")]
        public string Description { get; set; }
        public string url { get; set; }
        public string byline { get; set; }
        public string thumbnail_standard { get; set; }
        public string item_type { get; set; }
        public string source { get; set; }
        public DateTime updated_date { get; set; }
        public DateTime created_date { get; set; }
        public DateTime published_date { get; set; }
        public DateTime first_published_date { get; set; }
        public string material_type_facet { get; set; }
        public string kicker { get; set; }
        public object subheadline { get; set; }
        public object des_facet { get; set; }
        public object org_facet { get; set; }
        public object per_facet { get; set; }
        public object geo_facet { get; set; }
        public List<RelatedUrl> related_urls { get; set; }
        public List<Multimedia> multimedia { get; set; }
    }

    public class Content
    {
        public string status { get; set; }
        public string copyright { get; set; }
        public int num_results { get; set; }
        public List<NewInfo> results { get; set; }
    }
}