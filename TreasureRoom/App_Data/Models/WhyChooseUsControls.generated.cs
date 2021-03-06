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
	// Mixin Content Type with alias "whyChooseUsControls"
	/// <summary>Why Choose Us Controls</summary>
	public partial interface IWhyChooseUsControls : IPublishedContent
	{
		/// <summary>About Us Header</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		IHtmlString AboutUsHeader { get; }

		/// <summary>About Us Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		IPublishedContent AboutUsImage { get; }

		/// <summary>Bullet Point 1</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		IHtmlString BulletPoint1 { get; }

		/// <summary>Bullet Point 2</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		IHtmlString BulletPoint2 { get; }

		/// <summary>Bullet Point 3</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		IHtmlString BulletPoint3 { get; }

		/// <summary>Bullet Point 4</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		IHtmlString BulletPoint4 { get; }

		/// <summary>Main Text Heading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		IHtmlString MainTextHeading { get; }
	}

	/// <summary>Why Choose Us Controls</summary>
	[PublishedModel("whyChooseUsControls")]
	public partial class WhyChooseUsControls : PublishedContentModel, IWhyChooseUsControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const string ModelTypeAlias = "whyChooseUsControls";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<WhyChooseUsControls, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public WhyChooseUsControls(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// About Us Header
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("aboutUsHeader")]
		public IHtmlString AboutUsHeader => GetAboutUsHeader(this);

		/// <summary>Static getter for About Us Header</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IHtmlString GetAboutUsHeader(IWhyChooseUsControls that) => that.Value<IHtmlString>("aboutUsHeader");

		///<summary>
		/// About Us Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("aboutUsImage")]
		public IPublishedContent AboutUsImage => GetAboutUsImage(this);

		/// <summary>Static getter for About Us Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IPublishedContent GetAboutUsImage(IWhyChooseUsControls that) => that.Value<IPublishedContent>("aboutUsImage");

		///<summary>
		/// Bullet Point 1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("bulletPoint1")]
		public IHtmlString BulletPoint1 => GetBulletPoint1(this);

		/// <summary>Static getter for Bullet Point 1</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IHtmlString GetBulletPoint1(IWhyChooseUsControls that) => that.Value<IHtmlString>("bulletPoint1");

		///<summary>
		/// Bullet Point 2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("bulletPoint2")]
		public IHtmlString BulletPoint2 => GetBulletPoint2(this);

		/// <summary>Static getter for Bullet Point 2</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IHtmlString GetBulletPoint2(IWhyChooseUsControls that) => that.Value<IHtmlString>("bulletPoint2");

		///<summary>
		/// Bullet Point 3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("bulletPoint3")]
		public IHtmlString BulletPoint3 => GetBulletPoint3(this);

		/// <summary>Static getter for Bullet Point 3</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IHtmlString GetBulletPoint3(IWhyChooseUsControls that) => that.Value<IHtmlString>("bulletPoint3");

		///<summary>
		/// Bullet Point 4
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("bulletPoint4")]
		public IHtmlString BulletPoint4 => GetBulletPoint4(this);

		/// <summary>Static getter for Bullet Point 4</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IHtmlString GetBulletPoint4(IWhyChooseUsControls that) => that.Value<IHtmlString>("bulletPoint4");

		///<summary>
		/// Main Text Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("mainTextHeading")]
		public IHtmlString MainTextHeading => GetMainTextHeading(this);

		/// <summary>Static getter for Main Text Heading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IHtmlString GetMainTextHeading(IWhyChooseUsControls that) => that.Value<IHtmlString>("mainTextHeading");
	}
}
