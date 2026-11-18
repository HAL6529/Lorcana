using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_197_JA_08 : CardInfo
{
    public CardInfo_197_JA_08()
    {
        this.cardNo = "197_JA_08";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ヴィニー・サントリーニ";
        this.cardName2 = "爆破のプロ";
        this.power = 2;
        this.toughness = 8;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.HaJungSong;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
