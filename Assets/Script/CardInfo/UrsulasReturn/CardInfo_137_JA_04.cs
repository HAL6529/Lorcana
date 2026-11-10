using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_137_JA_04 : CardInfo
{
    public CardInfo_137_JA_04()
    {
        this.cardNo = "137_JA_04";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ƒAƒi";
        this.cardName2 = "—’‚É—§‚¿Œü‚©‚¤ŽÒ";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MariaDresden;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Queen };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
