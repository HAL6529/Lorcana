using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_014_JA_13 : CardInfo
{
    public CardInfo_014_JA_13()
    {
        this.cardNo = "014_JA_13";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "アビー・パーク";
        this.cardName2 = "アゲアゲシンガー";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JulesDubost;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TurningRed;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
