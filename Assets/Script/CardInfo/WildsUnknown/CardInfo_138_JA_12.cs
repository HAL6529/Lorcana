using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_138_JA_12 : CardInfo
{
    public CardInfo_138_JA_12()
    {
        this.cardNo = "138_JA_12";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "プリンス・チャーミング";
        this.cardName2 = "答えを求める王子";
        this.power = 1;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CarinaScyrinaHeller;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
