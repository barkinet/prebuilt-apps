﻿//
//  Copyright 2012  Xamarin Inc.
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldService.Data {
    /// <summary>
    /// Service for returning and saving assignment information
    /// </summary>
    public interface IAssignmentService {
        /// <summary>
        /// Gets a list of assignments
        /// </summary>
        Task<List<Assignment>> GetAssignmentsAsync ();

        /// <summary>
        /// Gets a list of items
        /// </summary>
        Task<List<Item>> GetItemsAsync ();

        /// <summary>
        /// Gets a list of items for an assignment
        /// </summary>
        Task<List<AssignmentItem>> GetItemsForAssignmentAsync (Assignment assignment);

        /// <summary>
        /// Saves an assignment
        /// </summary>
        /// <returns></returns>
        Task<int> SaveAssignment (Assignment assignment);

        /// <summary>
        /// Saves a labor entry
        /// </summary>
        /// <returns></returns>
        Task<int> SaveLabor (Labor labor);

        /// <summary>
        /// Saves an expense entry
        /// </summary>
        /// <returns></returns>
        Task<int> SaveExpense (Expense expense);
    }
}