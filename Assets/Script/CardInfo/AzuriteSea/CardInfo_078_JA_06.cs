using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_078_JA_06 : CardInfo
{
    public CardInfo_078_JA_06()
    {
        this.cardNo = "078_JA_06";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ヒースクリフ";
        this.cardName2 = "冷静沈着なる執事";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.VeronicaDiLorenzoAndLivioCacciatore;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
