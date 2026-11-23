using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_038_JA_11 : CardInfo
{
    public CardInfo_038_JA_11()
    {
        this.cardNo = "038_JA_11";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "アイシス・ヴァンダーチル";
        this.cardName2 = "セントカナードの氷の女王";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LissetteCarrera;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
