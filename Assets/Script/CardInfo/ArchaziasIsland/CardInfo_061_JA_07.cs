using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_061_JA_07 : CardInfo
{
    public CardInfo_061_JA_07()
    {
        this.cardNo = "061_JA_07";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ÉyÉCÉì";
        this.cardName2 = "Ç∏Ç§Ç∏Ç§ÇµÇ¢è¨à´ñÇ";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AriannaRea;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
