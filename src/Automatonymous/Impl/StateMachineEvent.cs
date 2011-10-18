// Copyright 2011 Chris Patterson, Dru Sellers
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Automatonymous.Impl
{
    using Internal;


    class StateMachineEvent<TInstance>
        where TInstance : class, StateMachineInstance
    {
        readonly Event _event;
        readonly Observable<EventRaised<TInstance>> _eventRaisedObservable;
        readonly Observable<EventRaising<TInstance>> _eventRaisingObservable;

        public StateMachineEvent(Event @event)
        {
            _event = @event;
            _eventRaisedObservable = new Observable<EventRaised<TInstance>>();
            _eventRaisingObservable = new Observable<EventRaising<TInstance>>();
        }

        public Event Event
        {
            get { return _event; }
        }

        public Observable<EventRaised<TInstance>> EventRaised
        {
            get { return _eventRaisedObservable; }
        }

        public Observable<EventRaising<TInstance>> EventRaising
        {
            get { return _eventRaisingObservable; }
        }
    }
}