using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_007_JA_08 : CardInfo
{
    public CardInfo_007_JA_08()
    {
        this.cardNo = "007_JA_08";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ルードヴィヒ・フォン・ドレイク";
        this.cardName2 = "万物の専門家";
        this.power = 1;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.PietroBZemelo;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
