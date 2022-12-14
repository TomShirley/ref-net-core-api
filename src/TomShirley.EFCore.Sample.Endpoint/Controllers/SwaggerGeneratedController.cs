//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.10.8.0 (NJsonSchema v10.3.11.0 (Newtonsoft.Json v12.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"

namespace TomShirley.EFCore.Sample.Endpoint.Controllers
{
    using System = global::System;
    
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.10.8.0 (NJsonSchema v10.3.11.0 (Newtonsoft.Json v12.0.0.0))")]
    public interface IBlogsController
    {
        /// <summary>Get a list of all blogs.</summary>
        /// <returns>The response to a request to get all blogs.</returns>
        System.Threading.Tasks.Task<BlogsGetResponse> GetBlogsAsync(HttpContext context);
    
        /// <summary>Get a single blog.</summary>
        /// <param name="id">The unique id of this blog used within the blogs system.</param>
        /// <returns>The response to a request to get a blog.</returns>
        System.Threading.Tasks.Task<Blog> GetBlogAsync(HttpContext context, System.Guid id);
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.10.8.0 (NJsonSchema v10.3.11.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class BlogsController : Controller
    {
        private IBlogsController _implementation;
    
        public BlogsController(IBlogsController implementation)
        {
            _implementation = implementation;
        }
    
        /// <summary>Get a list of all blogs.</summary>
        /// <returns>The response to a request to get all blogs.</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("blogs")]
        public System.Threading.Tasks.Task<BlogsGetResponse> GetBlogs()
        {
            return _implementation.GetBlogsAsync(HttpContext);
        }
    
        /// <summary>Get a single blog.</summary>
        /// <param name="id">The unique id of this blog used within the blogs system.</param>
        /// <returns>The response to a request to get a blog.</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("blogs/{id}")]
        public System.Threading.Tasks.Task<Blog> GetBlog(System.Guid id)
        {
            return _implementation.GetBlogAsync(HttpContext, id);
        }
    
    }

    /// <summary>A user in the blogs system</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class User 
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("firstName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("lastName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("username", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Username { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static User FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<User>(data);
        }
    
    }
    
    /// <summary>The blog object</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Post 
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }
    
        [Newtonsoft.Json.JsonProperty("blogId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid BlogId { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Post FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Post>(data);
        }
    
    }
    
    /// <summary>The blog object</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Blog 
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }
    
        [Newtonsoft.Json.JsonProperty("owner", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public User Owner { get; set; }
    
        [Newtonsoft.Json.JsonProperty("posts", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<Post> Posts { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Blog FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Blog>(data);
        }
    
    }
    
    /// <summary>The object used to represent a blog in a response.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class BlogsGetResponse 
    {
        [Newtonsoft.Json.JsonProperty("blogs", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<Blog> Blogs { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static BlogsGetResponse FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<BlogsGetResponse>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.11.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class ErrorResponse 
    {
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Message { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static ErrorResponse FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorResponse>(data);
        }
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108