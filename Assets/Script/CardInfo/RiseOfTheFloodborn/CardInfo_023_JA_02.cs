using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_023_JA_02 : CardInfo
{
    public CardInfo_023_JA_02()
    {
        this.cardNo = "023_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "îíê·ïP";
        this.cardName2 = "êXÇÃñ¿éq";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LadyShalirin;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
