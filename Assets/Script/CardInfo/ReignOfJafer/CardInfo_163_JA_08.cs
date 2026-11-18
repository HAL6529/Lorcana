using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_163_JA_08 : CardInfo
{
    public CardInfo_163_JA_08()
    {
        this.cardNo = "163_JA_08";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "小さなお姉ちゃん";
        this.cardName2 = "しっかりもののウサギ";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AndreaParisi;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
