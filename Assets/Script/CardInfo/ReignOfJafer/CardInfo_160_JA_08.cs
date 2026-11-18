using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_160_JA_08 : CardInfo
{
    public CardInfo_160_JA_08()
    {
        this.cardNo = "160_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ワードローブ";
        this.cardName2 = "おしゃれ顧問";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GiuliaRiva;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
