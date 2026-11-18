using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_181_JA_08 : CardInfo
{
    public CardInfo_181_JA_08()
    {
        this.cardNo = "181_JA_08";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "アティタヤ";
        this.cardName2 = "ファングの将軍";
        this.power = 7;
        this.toughness = 7;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.FrenchCarlomagno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
