﻿// This file is part of Hangfire. Copyright © 2022 Hangfire OÜ.
// 
// Hangfire is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as 
// published by the Free Software Foundation, either version 3 
// of the License, or any later version.
// 
// Hangfire is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public 
// License along with Hangfire. If not, see <http://www.gnu.org/licenses/>.

using System;
using Hangfire.Common;

namespace Hangfire.Storage.Monitoring
{
    public class ScheduledJobDto
    {
        public ScheduledJobDto()
        {
            InScheduledState = true;
        }

        public Job Job { get; set; }
        public DateTime EnqueueAt { get; set; }
        public DateTime? ScheduledAt { get; set; }
        public bool InScheduledState { get; set; }
    }
}