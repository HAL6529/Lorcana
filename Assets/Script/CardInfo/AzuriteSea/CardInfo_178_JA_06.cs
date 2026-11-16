using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_178_JA_06 : CardInfo
{
    public CardInfo_178_JA_06()
    {
        this.cardNo = "178_JA_06";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "コフート";
        this.cardName2 = "頼れる海兵隊員";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KevinSidharta;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
