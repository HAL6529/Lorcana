using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_215_JA_13 : CardInfo
{
    public CardInfo_215_JA_13()
    {
        this.cardNo = "215_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ケヴィン";
        this.cardName2 = "飛べない鳥";
        this.power = 1;
        this.toughness = 3;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.JiahuiEvaGao;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Up;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
