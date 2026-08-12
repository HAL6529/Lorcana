using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_085_JA_01 : CardInfo
{
    public CardInfo_085_JA_01()
    {
        this.cardNo = "085_JA_01";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "トレメイン夫人";
        this.cardName2 = "意地悪なまま母";
        this.power = 1;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = "Leonardo Giammichele";
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
