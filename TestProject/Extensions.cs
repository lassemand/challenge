using System;
using System.Collections.Generic;

namespace WhatTheFind
{
    public static class Extensions
    {
        // Error on the slides, node is undefined. I believe it should be nodeA


        /// <summary>
        /// Find any node in an object graph that satisfy a given predicate and return it.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="root">The root node.</param>
        /// <param name="predicate">The given condition to satisfy.</param>
        /// <param name="getChildren">Child selector.</param>
        /// <returns>Node satisfying the condtion, else null.</returns>
        public static T FindWhere<T>(this T root, Func<T, bool> predicate, Func<T, IEnumerable<T>> getChildren)
            where T : class
        {
            foreach (var child in getChildren.Invoke(root))
                if(predicate.Invoke(child))
                    return child;
            return null;
        }
    }
}
