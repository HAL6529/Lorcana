using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_113_JA_06 : CardInfo
{
    public CardInfo_113_JA_06()
    {
        this.cardNo = "113_JA_06";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "マルコフスキー";
        this.cardName2 = "宇宙兵士";
        this.power = 3;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.KevinSidharta;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
