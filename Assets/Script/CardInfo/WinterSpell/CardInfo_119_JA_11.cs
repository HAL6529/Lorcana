using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_119_JA_11 : CardInfo
{
    public CardInfo_119_JA_11()
    {
        this.cardNo = "119_JA_11";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "スラッシー";
        this.cardName2 = "ふぶき吹き";
        this.power = 5;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KevinSlawinski;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Alien };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
