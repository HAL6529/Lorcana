using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_172_JA_08 : CardInfo
{
    public CardInfo_172_JA_08()
    {
        this.cardNo = "172_JA_08";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ロクフォール";
        this.cardName2 = "カギ開けの名手";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AndersonMahanski;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheAristocats;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
