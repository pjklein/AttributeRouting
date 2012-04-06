namespace AttributeRouting.Constraints {
    public interface IAttributeRouteConstraint {
        /// <summary>
        /// The name of the route to apply this default against.
        /// </summary>
        string ForRouteNamed { get; set; }

        /// <summary>
        /// The key of the url parameter.
        /// </summary>
        string Key { get; }

        /// <summary>
        /// The TConstraint to apply against url parameters with the specified key.
        /// </summary>
        object Constraint { get; }
    }
}