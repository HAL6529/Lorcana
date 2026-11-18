using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_123_JA_08 : CardInfo
{
    public CardInfo_123_JA_08()
    {
        this.cardNo = "123_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ジャイロ・ギアルーズ";
        this.cardName2 = "エキセントリックな発明家";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.PietroBZemelo;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
