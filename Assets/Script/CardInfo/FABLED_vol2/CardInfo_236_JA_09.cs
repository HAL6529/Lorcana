using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_236_JA_09 : CardInfo
{
    public CardInfo_236_JA_09()
    {
        this.cardNo = "236_JA_09";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "クルエラ";
        this.cardName2 = "カリスマ・ファッショニスタ";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlexAccorsi;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol2;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
