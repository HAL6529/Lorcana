using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_101_JA_08 : CardInfo
{
    public CardInfo_101_JA_08()
    {
        this.cardNo = "101_JA_08";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ラプンツェル";
        this.cardName2 = "いと高き姫君";
        this.power = 2;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
