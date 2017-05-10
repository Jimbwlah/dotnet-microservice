namespace BS_Microservice.Unity
{
    using System;
    using System.Collections.Generic;
    using System.Web.Http.Dependencies;
    using Microsoft.Practices.Unity;
    
    /// <summary>
    /// Unity dependency resolver
    /// </summary>
    public class UnityResolver : IDependencyResolver
    {
        /// <summary>
        /// The container
        /// </summary>
        private readonly IUnityContainer container;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnityResolver" /> class.
        /// </summary>
        /// <param name="container">Returns the container</param>
        public UnityResolver(IUnityContainer container)
        {
            if (container == null)
            {
                throw new ArgumentNullException("container");
            }

            this.container = container;
        }

        /// <summary>
        /// Gets an individual service
        /// </summary>
        /// <param name="serviceType">The service type</param>
        /// <returns>The resolved container</returns>
        public object GetService(Type serviceType)
        {
            try
            {
                return this.container.Resolve(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return null;
            }
        }

        /// <summary>
        /// Gets multiple services
        /// </summary>
        /// <param name="serviceType">The service type</param>
        /// <returns>The resolved container</returns>
        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return this.container.ResolveAll(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return new List<object>();
            }
        }

        /// <summary>
        /// Start of scope
        /// </summary>
        /// <returns>The resolved container wrapped for Unity</returns>
        public IDependencyScope BeginScope()
        {
            var child = this.container.CreateChildContainer();
            return new UnityResolver(child);
        }

        /// <summary>
        /// Disposal of the container
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
        }

        /// <summary>
        /// Disposal of the container
        /// </summary>
        /// <param name="disposing">A boolean indicating whether disposal is required</param>
        protected virtual void Dispose(bool disposing)
        {
            this.container.Dispose();
        }
    }
}