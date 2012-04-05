﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Routing;
using AttributeRouting.Framework;
using AttributeRouting.Framework.Factories;

namespace AttributeRouting.Mvc.Framework {
    internal class RouteBuilder : RouteBuilder<IRouteConstraint, IController, AttributeRoute, UrlParameter> {
        public RouteBuilder(
            AttributeRoutingConfiguration<IRouteConstraint, IController, AttributeRoute, UrlParameter> configuration, 
            IAttributeRouteFactory<IRouteConstraint, IController, AttributeRoute, UrlParameter> routeFactory, 
            IConstraintFactory<IRouteConstraint> constraintFactory, IParameterFactory<UrlParameter> parameterFactory) 
            : base(configuration, routeFactory, constraintFactory, parameterFactory) {}
    }
}