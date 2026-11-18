using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_001_JA_08 : CardInfo
{
    public CardInfo_001_JA_08()
    {
        this.cardNo = "001_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ルーイ";
        this.cardName2 = "イケてるダック";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.FedericoMariaCugliari;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber};
        this.keywordAvility = new List<EnumController.KeywordAvility>() { };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
