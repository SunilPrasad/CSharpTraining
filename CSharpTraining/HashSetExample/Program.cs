using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetExample
{

    // A HashSet represents a set of unique items, just like a mathematical set(e.g. { 1, 2, 3 }). 
    //A set cannot contain duplicates and the order of items is not relevant.So, both { 1, 2, 3 }
    //and { 3, 2, 1 } are equal.

    class Program
    {
        static void Main(string[] args)
        {
            //var hashSet = new HashSet<int>();

            // Initialize the set using object initialization syntax 
            var hashSet = new HashSet<int>() { 1, 2, 3 };

            // Add an object to the set
            hashSet.Add(4);

            // Remove an object 
            hashSet.Remove(3);

            // Remove all objects 
            hashSet.Clear();

            // Check to see if the set contains an object 
            var contains = hashSet.Contains(1);

            // Return the number of objects in the set 
            var count = hashSet.Count;


            //// Modify the set to include only the objects present in the set and the other set
            //hashSet.IntersectWith(another);

            //// Remove all objects in "another" set from "hashSet" 
            //hashSet.ExceptWith(another);

            //// Modify the set to include all objects included in itself, in "another" set, or both
            //hashSet.UnionWith(another);

            //var isSupersetOf = hashSet.IsSupersetOf(another);
            //var isSubsetOf = hashSet.IsSubsetOf(another);
            //var equals = hashSet.SetEquals(another);

        }
    }


    /*Use a HashSet when you need super fast lookups against a unique list of items. 
     * For example, you might be processing a list of orders, and for each order, 
     * you need to quickly check the supplier code from a list of valid supplier codes.
     * 
     * 
     * */
}
