using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_085_JA_13 : CardInfo
{
    public CardInfo_085_JA_13()
    {
        this.cardNo = "085_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "アラジン";
        this.cardName2 = "これが俺の役目だ";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlejandroHernandez;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
