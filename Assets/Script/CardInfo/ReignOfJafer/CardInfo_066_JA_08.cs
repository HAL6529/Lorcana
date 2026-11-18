using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_066_JA_08 : CardInfo
{
    public CardInfo_066_JA_08()
    {
        this.cardNo = "066_JA_08";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "マジカ・デ・スペル";
        this.cardName2 = "影の姿";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.SandaraTang;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
