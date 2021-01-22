//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.1.6
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedModels
{
	// Mixin Content Type with alias "testimonialsControls"
	/// <summary>Testimonials Controls</summary>
	public partial interface ITestimonialsControls : IPublishedContent
	{
		/// <summary>Aryan Dang Text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		IHtmlString AryanDangText { get; }

		/// <summary>Testimonials Header</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		IHtmlString TestimonialsHeader { get; }

		/// <summary>Testimonials Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		IPublishedContent TestimonialsImage { get; }
	}

	/// <summary>Testimonials Controls</summary>
	[PublishedModel("testimonialsControls")]
	public partial class TestimonialsControls : PublishedContentModel, ITestimonialsControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const string ModelTypeAlias = "testimonialsControls";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TestimonialsControls, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public TestimonialsControls(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Aryan Dang Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("aryanDangText")]
		public IHtmlString AryanDangText => GetAryanDangText(this);

		/// <summary>Static getter for Aryan Dang Text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IHtmlString GetAryanDangText(ITestimonialsControls that) => that.Value<IHtmlString>("aryanDangText");

		///<summary>
		/// Testimonials Header
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("testimonialsHeader")]
		public IHtmlString TestimonialsHeader => GetTestimonialsHeader(this);

		/// <summary>Static getter for Testimonials Header</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IHtmlString GetTestimonialsHeader(ITestimonialsControls that) => that.Value<IHtmlString>("testimonialsHeader");

		///<summary>
		/// Testimonials Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("testimonialsImage")]
		public IPublishedContent TestimonialsImage => GetTestimonialsImage(this);

		/// <summary>Static getter for Testimonials Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IPublishedContent GetTestimonialsImage(ITestimonialsControls that) => that.Value<IPublishedContent>("testimonialsImage");
	}
}
