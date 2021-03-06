/*
  Copyright (c) Microsoft Corporation. All rights reserved.
  Licensed under the MIT License. See License.txt in the project root for license information.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adxstudio.Xrm.Events;
using Microsoft.Xrm.Sdk;

namespace Adxstudio.Xrm.Web.Mvc.Liquid
{
	public class SpeakerDrop : EntityDrop
	{
		public SpeakerDrop(IPortalLiquidContext portalLiquidContext, IEventSpeaker eventSpeaker)
			: base(portalLiquidContext, eventSpeaker.Entity)
		{

		}

	}
}
