using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_233_JA_13 : CardInfo
{
    public CardInfo_233_JA_13()
    {
        this.cardNo = "233_JA_13";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ピーター・パン＆ティンカー・ベル";
        this.cardName2 = "飛びっきりの友だち";
        this.power = 5;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Team, EnumController.Class.Hero, EnumController.Class.Fairy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
