using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_232_JA_13 : CardInfo
{
    public CardInfo_232_JA_13()
    {
        this.cardNo = "232_JA_13";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "アラジン＆ジーニー";
        this.cardName2 = "イタズラ仲間";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.NuelSalinasAndPaloGraglia;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Team, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
