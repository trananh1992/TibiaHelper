﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TibiaHeleper.Modules.WalkerModule
{
    [Serializable]
    public class Action : WalkerStatement, ICloneable
    {
        public int defaultAction;

        public object[] args;

        public Action(int defaultActionType, params object[] arguments)
        {
            defaultAction = defaultActionType;
            args = arguments;
            type = StatementType.getType["Action"];
            name = "Action: " + StatementType.getTypeByValue(defaultActionType);
            if (defaultActionType == StatementType.getType["Go To Label"]) name = "Action: Go to \"" + arguments[0] + "\"";
            else if (defaultActionType == StatementType.getType["Say"]) name = "Action: Say \"" + arguments[0] + "\"";
            else if (defaultActionType == StatementType.getType["Condition"]) name = "Condition -> \"" + arguments[0] +"\"";
        }

        public void DoAction()
        {
            DefaultActions.DoAction(defaultAction, args);
        }

        public override object Clone()
        {
            return MemberwiseClone();
        }
    }
}
