using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_080_JA_02 : CardInfo
{
    public CardInfo_080_JA_02()
    {
        this.cardNo = "080_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ñÇèó";
        this.cardName2 = "Ç‹Ç≥Ç©ÇÃçŸÇ´êl";
        this.power = 1;
        this.toughness = 1;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.IsaiahMesq;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
