using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_122_JA_04 : CardInfo
{
    public CardInfo_122_JA_04()
    {
        this.cardNo = "122_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ÉâÅ[ÉÑ";
        this.cardName2 = "ó¥ÇÃêŒÇÃéÁÇËêl";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.BrittneyHackett;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
