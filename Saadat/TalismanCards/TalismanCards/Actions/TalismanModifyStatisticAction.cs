﻿namespace TalismanCards.Actions
{
    internal class TalismanModifyStatisticAction:ITalismanAction
    {
        private int v;
        private object cRAFT;

        public TalismanModifyStatisticAction(int v, object cRAFT)
        {
            this.v = v;
            this.cRAFT = cRAFT;
        }
    }
}