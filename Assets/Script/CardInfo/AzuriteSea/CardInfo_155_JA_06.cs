using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_155_JA_06 : CardInfo
{
    public CardInfo_155_JA_06()
    {
        this.cardNo = "155_JA_06";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "タダシ・ハマダ";
        this.cardName2 = "ロボット工学の天才";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AilbethZermeno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
