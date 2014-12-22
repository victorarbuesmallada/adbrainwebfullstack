using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reddit.DataTransfer
{
    public class ItemData
    {
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }

        [JsonProperty(PropertyName = "banned_by")]
        public string BannedBy { get; set; }

        [JsonProperty(PropertyName = "media_embed")]
        public dynamic MediaEmbed { get; set; }

        [JsonProperty(PropertyName = "subreddit")]
        public string SubReddit { get; set; }

        [JsonProperty(PropertyName = "selftext_html")]
        public string SelfTextHtml { get; set; }

        [JsonProperty(PropertyName = "selftext")]
        public string SelfText { get; set; }

        [JsonProperty(PropertyName = "likes")]
        public int? Likes { get; set; }

        [JsonProperty(PropertyName = "user_reports")]
        public dynamic[] UserReports { get; set; }

        [JsonProperty(PropertyName = "secure_media")]
        public dynamic SecureMedia { get; set; }

        [JsonProperty(PropertyName = "link_flair_text")]
        public string LinkFlairText { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "gilded")]
        public int? Gilded { get; set; }

        [JsonProperty(PropertyName = "secure_media_embed")]
        public dynamic SecureMediaEmbed { get; set; }

        [JsonProperty(PropertyName = "clicked")]
        public bool Clicked { get; set; }

        [JsonProperty(PropertyName = "report_reasons")]
        public string ReportReasons { get; set; }

        [JsonProperty(PropertyName = "author")]
        public string Author { get; set; }

        [JsonProperty(PropertyName = "media")]
        public dynamic Media { get; set; }

        [JsonProperty(PropertyName = "score")]
        public int Score { get; set; }

        [JsonProperty(PropertyName = "approved_by")]
        public string ApprovedBy { get; set; }

        [JsonProperty(PropertyName = "over_18")]
        public bool Over18 { get; set; }

        [JsonProperty(PropertyName = "hidden")]
        public bool Hidden { get; set; }

        [JsonProperty(PropertyName = "thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty(PropertyName = "subreddit_id")]
        public string SubredditId { get; set; }

        [JsonProperty(PropertyName = "edited")]
        public bool Edited { get; set; }

        [JsonProperty(PropertyName = "link_flair_css_class")]
        public string LinkFlairCssClass { get; set; }

        [JsonProperty(PropertyName = "author_flair_css_class")]
        public string AuthorFlairCssClass { get; set; }

        [JsonProperty(PropertyName = "downs")]
        public int Downs { get; set; }

        [JsonProperty(PropertyName = "mod_reports")]
        public dynamic[] ModReports { get; set; }

        [JsonProperty(PropertyName = "saved")]
        public bool Saved { get; set; }

        [JsonProperty(PropertyName = "is_self")]
        public bool IsSelf { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "permalink")]
        public string PermaLink { get; set; }

        [JsonProperty(PropertyName = "stickied")]
        public bool Stickied { get; set; }

        [JsonProperty(PropertyName = "created")]
        public long Created { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "author_flair_text")]
        public string AuthorFlairText { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "created_utc")]
        public long CreatedUtc { get; set; }

        [JsonProperty(PropertyName = "ups")]
        public int Ups { get; set; }

        [JsonProperty(PropertyName = "num_comments")]
        public int NumComments { get; set; }

        [JsonProperty(PropertyName = "visited")]
        public bool Visited { get; set; }

        [JsonProperty(PropertyName = "num_reports")]
        public int? NumReports { get; set; }

        [JsonProperty(PropertyName = "distinguished")]
        public string Distinguished { get; set; }
    }
}
