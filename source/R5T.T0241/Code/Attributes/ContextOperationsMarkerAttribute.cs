using System;

using R5T.T0143;


namespace R5T.T0241
{
    /// <summary>
    /// <para>Context operation interface names should be <b>plural</b>. Example: "IRepositoryContextOperations".</para>
    /// Attribute indicating an interface contains context operation values (methods and properties).
    /// Context operations are implemented as either:
    /// <list type="number">
    /// <item>
    /// Methods with a single generic TContext context type parameter, taking in a single input of TContext type,
    /// and producing either Task (asynchronous operations, the default) or void (synchronous operations).
    /// </item>
    /// <item>
    /// Methods with a generic TContext context type parameter, and zero or more other type parameters, taking in zero or more inputs that are generally <em>not</em> of TContext type,
    /// producing a closure of the type Funct&lt;TContext, Task&gt; (asynchronous operations, the default) or Action&lt;TContext&gt; (synchronous operations).
    /// </item>
    /// <item>
    /// A non-generic type property (because properties cannot be generic) of the type
    /// Funct&lt;ContextType, Task&gt; (asynchronous operations, the default) or Action&lt;ContextType&gt; (synchronous operations) that performs the work of specifying the TContext type.
    /// </item>
    /// </list>
    /// <para>Context operation instance interface types should <em>not</em> be generic in the TContext type! The generic TContext type should be reserved for the individual methods.</para>
    /// The marker attribute is useful for surveying values classes and building a catalogue of values.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class ContextOperationsMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        /// <summary>
        /// Allows specifying that an interface is *not* a context operations values interface.
        /// This is useful for marking interface that end up canonical context operations values code file locations, but are not context operations values interface types.
        /// </summary>
        public bool IsContextOperations { get; }


        public ContextOperationsMarkerAttribute(
            bool isContextOperations = true)
        {
            this.IsContextOperations = isContextOperations;
        }
    }
}
