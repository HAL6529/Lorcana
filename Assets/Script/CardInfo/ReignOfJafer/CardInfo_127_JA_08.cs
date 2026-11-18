using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_127_JA_08 : CardInfo
{
    public CardInfo_127_JA_08()
    {
        this.cardNo = "127_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "アリス";
        this.cardName2 = "鍵をにぎる少女";
        this.power = 2;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.FilipeLaurentino;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
