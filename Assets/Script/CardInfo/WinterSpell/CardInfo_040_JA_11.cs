using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_040_JA_11 : CardInfo
{
    public CardInfo_040_JA_11()
    {
        this.cardNo = "040_JA_11";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "モルガナ・マカーバー";
        this.cardName2 = "自己中心的な呪文使い";
        this.power = 5;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ChemeneDeHeus;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
