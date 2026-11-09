using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_126_JA_04 : CardInfo
{
    public CardInfo_126_JA_04()
    {
        this.cardNo = "126_JA_04";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ÉgÉìÉO";
        this.cardName2 = "óBàÍÇÃê∂ë∂é“";
        this.power = 3;
        this.toughness = 6;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.MikeParker;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Reckless };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
