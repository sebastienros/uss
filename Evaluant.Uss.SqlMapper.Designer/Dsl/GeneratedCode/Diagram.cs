﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;

[module: global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Scope = "type", Target = "Evaluant.Uss.SqlMapper.Mapping.SqlMapperMappingDiagram")]

namespace Evaluant.Uss.SqlMapper.Mapping
{
	/// <summary>
	/// DomainClass SqlMapperMappingDiagram
	/// Description for Evaluant.Uss.SqlMapper.Mapping.SqlMapperMappingDiagram
	/// </summary>
	[DslDesign::DisplayNameResource("Evaluant.Uss.SqlMapper.Mapping.SqlMapperMappingDiagram.DisplayName", typeof(global::Evaluant.Uss.SqlMapper.Mapping.SqlMapperMappingDomainModel), "Evaluant.Uss.SqlMapper.Mapping.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Evaluant.Uss.SqlMapper.Mapping.SqlMapperMappingDiagram.Description", typeof(global::Evaluant.Uss.SqlMapper.Mapping.SqlMapperMappingDomainModel), "Evaluant.Uss.SqlMapper.Mapping.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Evaluant.Uss.SqlMapper.Mapping.SqlMapperMappingDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("8f33c714-9930-407d-8ac9-6e2fedcb7457")]
	public partial class SqlMapperMappingDiagram : DslDiagrams::Diagram
	{
		#region Diagram boilerplate
		private static DslDiagrams::StyleSet classStyleSet;
		private static global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields;
		/// <summary>
		/// Per-class style set for this shape.
		/// </summary>
		protected override DslDiagrams::StyleSet ClassStyleSet
		{
			get
			{
				if (classStyleSet == null)
				{
					classStyleSet = CreateClassStyleSet();
				}
				return classStyleSet;
			}
		}
		
		/// <summary>
		/// Per-class ShapeFields for this shape
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::ShapeField> ShapeFields
		{
			get
			{
				if (shapeFields == null)
				{
					shapeFields = CreateShapeFields();
				}
				return shapeFields;
			}
		}
		#endregion
		#region Toolbox filters
		private static global::System.ComponentModel.ToolboxItemFilterAttribute[] toolboxFilters = new global::System.ComponentModel.ToolboxItemFilterAttribute[] {
					new global::System.ComponentModel.ToolboxItemFilterAttribute(global::Evaluant.Uss.SqlMapper.Mapping.SqlMapperMappingToolboxHelperBase.ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) };
		
		/// <summary>
		/// Toolbox item filter attributes for this diagram.
		/// </summary>
		public override global::System.Collections.ICollection TargetToolboxItemFilterAttributes
		{
			get
			{
				return toolboxFilters;
			}
		}
		#endregion
		#region Auto-placement
		/// <summary>
		/// Indicate that child shapes should added through view fixup should be placed automatically.
		/// </summary>
		public override bool ShouldAutoPlaceChildShapes
		{
			get
			{
				return true;
			}
		}
		#endregion
		#region Shape mapping
		/// <summary>
		/// Called during view fixup to ask the parent whether a shape should be created for the given child element.
		/// </summary>
		/// <remarks>
		/// Always return true, since we assume there is only one diagram per model file for DSL scenarios.
		/// </remarks>
		protected override bool ShouldAddShapeForElement(DslModeling::ModelElement element)
		{
			return true;
		}
		
		
		/// <summary>
		/// Most connectors are mapped to element links, but there can be exceptions. This method tell if a connector should be
		/// mapped to an element link.
		/// </summary>
		public override bool IsConnectorMappedToLink(DslDiagrams::BinaryLinkShape connector)
		{
			#region Check Parameters
			global::System.Diagnostics.Debug.Assert(connector != null);
			if (connector == null)
				throw new global::System.ArgumentNullException("connector");
			#endregion
			if (connector.GetType() == typeof(global::Evaluant.Uss.SqlMapper.Mapping.Relationshipshape))
				return false;
			return base.IsConnectorMappedToLink(connector);
		}
		
		/// <summary>
		/// Creates a new shape for the given model element as part of view fixup
		/// </summary>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily", Justification = "Generated code.")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]
		protected override DslDiagrams::ShapeElement CreateChildShape(DslModeling::ModelElement element)
		{
			if(element is global::Evaluant.Uss.SqlMapper.Mapping.Entity)
			{
				global::Evaluant.Uss.SqlMapper.Mapping.EntityShape newShape = new global::Evaluant.Uss.SqlMapper.Mapping.EntityShape(this.Partition);
				if(newShape != null) newShape.Size = newShape.DefaultSize; // set default shape size
				return newShape;
			}
			return base.CreateChildShape(element);
		}
		#endregion
		#region Decorator mapping
		/// <summary>
		/// Initialize shape decorator mappings.  This is done here rather than in individual shapes because decorator maps
		/// are defined per diagram type rather than per shape type.
		/// </summary>
		protected override void InitializeShapeFields(global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields)
		{
			base.InitializeShapeFields(shapeFields);
		}
		
		#endregion
		
		#region Connect actions
		private bool changingMouseAction;
		private global::Evaluant.Uss.SqlMapper.Mapping.ExampleRelationshipConnectAction exampleRelationshipConnectAction;
		/// <summary>
		/// Virtual method to provide a filter when to select the mouse action
		/// </summary>
		/// <param name="activeView">Currently active view</param>
		/// <param name="filter">filter string used to filter the toolbox items</param>
		protected virtual bool SelectedToolboxItemSupportsFilterString(DslDiagrams::DiagramView activeView, string filter)
		{
			return activeView.SelectedToolboxItemSupportsFilterString(filter);
		}
		/// <summary>
		/// Override to provide the right mouse action when trying
		/// to create links on the diagram
		/// </summary>
		/// <param name="pointArgs"></param>
		public override void OnViewMouseEnter(DslDiagrams::DiagramPointEventArgs pointArgs)
		{
			if (pointArgs  == null) throw new global::System.ArgumentNullException("pointArgs");
		
			DslDiagrams::DiagramView activeView = this.ActiveDiagramView;
			if(activeView != null)
			{
				DslDiagrams::MouseAction action = null;
				if (SelectedToolboxItemSupportsFilterString(activeView, global::Evaluant.Uss.SqlMapper.Mapping.SqlMapperMappingToolboxHelper.ExampleRelationshipFilterString))
				{
					if (this.exampleRelationshipConnectAction == null)
					{
						this.exampleRelationshipConnectAction = new global::Evaluant.Uss.SqlMapper.Mapping.ExampleRelationshipConnectAction(this);
						this.exampleRelationshipConnectAction.MouseActionDeactivated += new DslDiagrams::MouseAction.MouseActionDeactivatedEventHandler(OnConnectActionDeactivated);
					}
					action = this.exampleRelationshipConnectAction;
				} 
				else
				{
					action = null;
				}
				
				if (pointArgs.DiagramClientView.ActiveMouseAction != action)
				{
					try
					{
						this.changingMouseAction = true;
						pointArgs.DiagramClientView.ActiveMouseAction = action;
					}
					finally
					{
						this.changingMouseAction = false;
					}
				}
			}
		}
		
		/// <summary>
		/// Snap toolbox selection back to regular pointer after using a custom connect action.
		/// </summary>
		private void OnConnectActionDeactivated(object sender, DslDiagrams::DiagramEventArgs e)
		{
			OnMouseActionDeactivated();
		}
		
		/// <summary>
		/// Overridable method to manage the mouse deactivation. The default implementation snap stoolbox selection back to regular pointer 
		/// after using a custom connect action.
		/// </summary>
		protected virtual void OnMouseActionDeactivated()
		{
			DslDiagrams::DiagramView activeView = this.ActiveDiagramView;
		
			if (activeView != null && activeView.Toolbox != null)
			{
				// If we're not changing mouse action due to changing toolbox selection change,
				// reset toolbox selection.
				if (!this.changingMouseAction)
				{
					activeView.Toolbox.SelectedToolboxItemUsed();
				}
			}
		}
		#endregion
		
		/// <summary>
		/// Dispose of connect actions.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			try
			{
				if(disposing)
				{
					if(this.exampleRelationshipConnectAction != null)
					{
						this.exampleRelationshipConnectAction.Dispose();
						this.exampleRelationshipConnectAction = null;
					}
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		#region Constructors, domain class Id
	
		/// <summary>
		/// SqlMapperMappingDiagram domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x8f33c714, 0x9930, 0x407d, 0x8a, 0xc9, 0x6e, 0x2f, 0xed, 0xcb, 0x74, 0x57);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public SqlMapperMappingDiagram(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public SqlMapperMappingDiagram(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region EntityShapes opposite domain role accessor
		
		/// <summary>
		/// Gets a list of EntityShapes.
		/// Description for
		/// Evaluant.Uss.SqlMapper.Mapping.SqlMapperMappingDiagramReferencesEntityShapes.SqlMapperMappingDiagram
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<EntityShape> EntityShapes
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<EntityShape>, EntityShape>(global::Evaluant.Uss.SqlMapper.Mapping.SqlMapperMappingDiagramReferencesEntityShapes.SqlMapperMappingDiagramDomainRoleId);
			}
		}
		#endregion
	}
}
namespace Evaluant.Uss.SqlMapper.Mapping
{
	
		/// <summary>
		/// Double derived implementation for the rule that initiates view fixup when an element that has an associated shape is added to the model.
		/// This now enables the DSL author to everride the SkipFixUp() method 
		/// </summary>
		internal partial class FixUpDiagramBase : DslModeling::AddRule
		{
			protected virtual bool SkipFixup(DslModeling::ModelElement childElement)
			{
				return childElement.IsDeleted;
			}
		}
	
		/// <summary>
		/// Rule that initiates view fixup when an element that has an associated shape is added to the model. 
		/// </summary>
		[DslModeling::RuleOn(typeof(global::Evaluant.Uss.SqlMapper.Mapping.Entity), FireTime = DslModeling::TimeToFire.TopLevelCommit, Priority = DslDiagrams::DiagramFixupConstants.AddShapeParentExistRulePriority, InitiallyDisabled=true)]
		internal sealed partial class FixUpDiagram : FixUpDiagramBase
		{
			[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
			public override void ElementAdded(DslModeling::ElementAddedEventArgs e)
			{
				if(e == null) throw new global::System.ArgumentNullException("e");
			
				DslModeling::ModelElement childElement = e.ModelElement;
				if (this.SkipFixup(childElement))
					return;
				DslModeling::ModelElement parentElement;
				if(childElement is global::Evaluant.Uss.SqlMapper.Mapping.Entity)
				{
					// Method:
					// private Microsoft.VisualStudio.Modeling.ModelElement GetParentForEntity(Entity childElement)
					// {
					// }
					// must be implemented in a partial class of Evaluant.Uss.SqlMapper.Mapping.FixUpDiagram.  Given a child element,
					// this method should return the parent model element that is associated with the shape or diagram that will be the parent 
					// of the shape created for this child.  If no shape should be created, the method should return null.
					parentElement = GetParentForEntity((global::Evaluant.Uss.SqlMapper.Mapping.Entity)childElement);
				} else
				{
					parentElement = null;
				}
				
				if(parentElement != null)
				{
					DslDiagrams::Diagram.FixUpDiagram(parentElement, childElement);
				}
			}
		}
		
	
	}