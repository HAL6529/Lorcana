using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_003_JA_08 : CardInfo
{
    public CardInfo_003_JA_08()
    {
        this.cardNo = "003_JA_08";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ヒューイ";
        this.cardName2 = "頼れるリーダー";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FedericoMariaCugliari;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
