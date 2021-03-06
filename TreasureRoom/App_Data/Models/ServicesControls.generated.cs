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
	// Mixin Content Type with alias "servicesControls"
	/// <summary>Services Controls</summary>
	public partial interface IServicesControls : IPublishedContent
	{
		/// <summary>First Column Heading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		IHtmlString FirstColumnHeading { get; }

		/// <summary>First Column Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		IPublishedContent FirstColumnImage { get; }

		/// <summary>First Column Text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		IHtmlString FirstColumnText { get; }

		/// <summary>Second Column Heading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		IHtmlString SecondColumnHeading { get; }

		/// <summary>Second Column Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		IPublishedContent SecondColumnImage { get; }

		/// <summary>Second Column Text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		IHtmlString SecondColumnText { get; }

		/// <summary>Services Header</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		IHtmlString ServicesHeader { get; }

		/// <summary>Third Column Heading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		IHtmlString ThirdColumnHeading { get; }

		/// <summary>Third Column Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		IPublishedContent ThirdColumnImage { get; }

		/// <summary>Third Column Text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		IHtmlString ThirdColumnText { get; }
	}

	/// <summary>Services Controls</summary>
	[PublishedModel("servicesControls")]
	public partial class ServicesControls : PublishedContentModel, IServicesControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const string ModelTypeAlias = "servicesControls";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ServicesControls, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ServicesControls(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// First Column Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("firstColumnHeading")]
		public IHtmlString FirstColumnHeading => GetFirstColumnHeading(this);

		/// <summary>Static getter for First Column Heading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IHtmlString GetFirstColumnHeading(IServicesControls that) => that.Value<IHtmlString>("firstColumnHeading");

		///<summary>
		/// First Column Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("firstColumnImage")]
		public IPublishedContent FirstColumnImage => GetFirstColumnImage(this);

		/// <summary>Static getter for First Column Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IPublishedContent GetFirstColumnImage(IServicesControls that) => that.Value<IPublishedContent>("firstColumnImage");

		///<summary>
		/// First Column Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("firstColumnText")]
		public IHtmlString FirstColumnText => GetFirstColumnText(this);

		/// <summary>Static getter for First Column Text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IHtmlString GetFirstColumnText(IServicesControls that) => that.Value<IHtmlString>("firstColumnText");

		///<summary>
		/// Second Column Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("secondColumnHeading")]
		public IHtmlString SecondColumnHeading => GetSecondColumnHeading(this);

		/// <summary>Static getter for Second Column Heading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IHtmlString GetSecondColumnHeading(IServicesControls that) => that.Value<IHtmlString>("secondColumnHeading");

		///<summary>
		/// Second Column Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("secondColumnImage")]
		public IPublishedContent SecondColumnImage => GetSecondColumnImage(this);

		/// <summary>Static getter for Second Column Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IPublishedContent GetSecondColumnImage(IServicesControls that) => that.Value<IPublishedContent>("secondColumnImage");

		///<summary>
		/// Second Column Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("secondColumnText")]
		public IHtmlString SecondColumnText => GetSecondColumnText(this);

		/// <summary>Static getter for Second Column Text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IHtmlString GetSecondColumnText(IServicesControls that) => that.Value<IHtmlString>("secondColumnText");

		///<summary>
		/// Services Header
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("servicesHeader")]
		public IHtmlString ServicesHeader => GetServicesHeader(this);

		/// <summary>Static getter for Services Header</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IHtmlString GetServicesHeader(IServicesControls that) => that.Value<IHtmlString>("servicesHeader");

		///<summary>
		/// Third Column Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("thirdColumnHeading")]
		public IHtmlString ThirdColumnHeading => GetThirdColumnHeading(this);

		/// <summary>Static getter for Third Column Heading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IHtmlString GetThirdColumnHeading(IServicesControls that) => that.Value<IHtmlString>("thirdColumnHeading");

		///<summary>
		/// Third Column Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("thirdColumnImage")]
		public IPublishedContent ThirdColumnImage => GetThirdColumnImage(this);

		/// <summary>Static getter for Third Column Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IPublishedContent GetThirdColumnImage(IServicesControls that) => that.Value<IPublishedContent>("thirdColumnImage");

		///<summary>
		/// Third Column Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("thirdColumnText")]
		public IHtmlString ThirdColumnText => GetThirdColumnText(this);

		/// <summary>Static getter for Third Column Text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IHtmlString GetThirdColumnText(IServicesControls that) => that.Value<IHtmlString>("thirdColumnText");
	}
}
