using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_138_JA_06 : CardInfo
{
    public CardInfo_138_JA_06()
    {
        this.cardNo = "138_JA_06";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "キャスおばさん";
        this.cardName2 = "最高のファン";
        this.power = 1;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.KendallHale;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
