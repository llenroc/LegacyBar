/*
 * Copyright (C) 2013 Tomasz Cielecki <tomasz@ostebaronen.dk>
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using Android.Content;
using Android.Views;

namespace LegacyBar.Library.BarActions
{
    public class ActionLegacyBarAction : LegacyBarAction
    {
        private readonly Action _action;

        public ActionLegacyBarAction(Context context, Action action, int drawable)
        {
            Drawable = drawable;
            Context = context;
            _action = action;
        }

        public override int GetDrawable()
        {
            return Drawable;
        }

        public override void PerformAction(View view)
        {
            _action.Invoke();
        }
    }
}