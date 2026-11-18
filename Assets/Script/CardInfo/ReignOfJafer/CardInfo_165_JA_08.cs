using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_165_JA_08 : CardInfo
{
    public CardInfo_165_JA_08()
    {
        this.cardNo = "165_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ナニ";
        this.cardName2 = "強だつ作戦の首ぼう者";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlexAccorsi;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
